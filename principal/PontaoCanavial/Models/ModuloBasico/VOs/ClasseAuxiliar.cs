using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using PontaoCanavial.Models.ModuloBasico.Constantes;
using PontaoCanavial.Models.ModuloPonto.VOs;


namespace PontaoCanavial.Models.ModuloBasico.VOs
{

    /// <summary>
    /// Summary description for ClasseAuxiliar
    /// </summary>
    public partial class ClasseAuxiliar
    {

        private static PontoFormViewModel pontoFormViewModel;

        public static PontoFormViewModel PontoFormViewModel
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["PontoFormViewModel"] != null)
                    pontoFormViewModel = (PontoFormViewModel)System.Web.HttpContext.Current.Session["PontoFormViewModel"];
                else
                    pontoFormViewModel = PontoFormViewModel;

                return pontoFormViewModel;
            }
            private set { pontoFormViewModel = value; }
        }

        private static int pontoID;
        public static int PontoID
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["PontoID"] != null)
                    pontoID = (int)System.Web.HttpContext.Current.Session["PontoID"];
                else
                    pontoID = 0;

                return pontoID;
            }
            private set { pontoID = value; }
        }
        private static Usuario usuarioLogado;

        public static Usuario UsuarioLogado
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UsuarioLogado"] != null)
                    usuarioLogado = (Usuario)System.Web.HttpContext.Current.Session["UsuarioLogado"];
                else
                    usuarioLogado = null;

                return usuarioLogado;
            }
            private set { usuarioLogado = value; }
        }

        private static List<UsuarioPonto> usuarioPontoLogadoLista;

        public static List<UsuarioPonto> UsuarioPontoLogadoLista
        {
            get
            {
                if (System.Web.HttpContext.Current.Session["UsuarioPontoLogadoLista"] != null)
                    usuarioPontoLogadoLista = (List<UsuarioPonto>)System.Web.HttpContext.Current.Session["UsuarioPontoLogadoLista"];
                else
                    usuarioPontoLogadoLista = null;

                return usuarioPontoLogadoLista;
            }
            private set { usuarioPontoLogadoLista = value; }
        }


        public static void CarregarComboEnum<T>(DropDownList cbo)
        {
            cbo.Items.Clear();

            Type objType = typeof(T);
            FieldInfo[] propriedades = objType.GetFields();

            foreach (FieldInfo objField in propriedades)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])objField.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes.Length > 0)
                    cbo.Items.Add(new ListItem(attributes[0].Description, objField.GetRawConstantValue().ToString()));
            }
        }

        public static bool VerificarUsuarioPonto(int pontoID)
        {
            bool resultado = false;
            if(UsuarioPontoLogadoLista!=null)
            {
                List<UsuarioPonto> lista = (from up in UsuarioPontoLogadoLista
                                            where up.PontoID == pontoID
                                            select up).ToList();
                resultado = lista.Count > 0;
            }
           

            return resultado;
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;

        }


    }

}