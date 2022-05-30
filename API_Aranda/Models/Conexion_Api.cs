using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace API_Aranda.Models
{
    public class Conexion_Api
    {
        //metodo para serializar la petición 
        public string Iniciar_Sesion<aserializar>(string parametro, aserializar datos_sesion, string method = "POST")
        {
            string resultado = "No respuesta";

            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = JsonConvert.SerializeObject(datos_sesion);

                //peticion
                WebRequest request = WebRequest.Create(parametro);

                request.Method = method;
                request.ContentType = "application/json;charset=utf-8'";


                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    resultado = streamReader.ReadToEnd().Trim();
                }

            }
            catch (Exception e)
            {

                resultado = e.Message;

            }

            return resultado;
        }




    }
}