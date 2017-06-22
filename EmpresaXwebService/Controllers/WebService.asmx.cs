using EmpresaXwebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace EmpresaXwebService.Controllers
{
    /// <summary>
    /// Descrição resumida de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string HelloWorld()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();



            return js.Serialize("Olá, Mundo");
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string getPecaById(int id)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            using (masterEntities db = new masterEntities())
            {
                return js.Serialize(db.Peca.FirstOrDefault(x => x.id.Equals(id)));
            }
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string setServico(
        //Serviço
        int clienteId, decimal valorTotal,
        //Usuario
        int usuarioId, string senha,
        //Peca
        int pecaId,
        //Usinagem
        double grande, double medio, double pequeno
        )
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            using (masterEntities db = new masterEntities())
            {
                OrdemDeServico servico = new OrdemDeServico()
                {
                    clienteId = clienteId,
                    Cliente = db.Cliente.First(x => x.id.Equals(clienteId)),
                    valorTotal = valorTotal,
                    Peca = db.Peca.First(x => x.id.Equals(pecaId)),
                    Usinagem = new Usinagem()
                    {
                        grande = grande,
                        medio = medio,
                        pequeno = pequeno,
                    },
                    pecaId = pecaId,
                    Usuario = db.Usuario.First(x => x.id.Equals(usuarioId)),
                    usuarioId = usuarioId
                };
                if (servico.Usuario.funcao.Trim().ToLower() != "atendente")
                {

                    return js.Serialize("Usuario não autorizado!");
                }
                try
                {
                    db.OrdemDeServico.Add(servico);
                    db.SaveChanges();
                    return js.Serialize("Success");
                }
                catch (Exception e)
                {
                    return js.Serialize("Erro" + e.InnerException);
                }
            }
        }
    }
}
