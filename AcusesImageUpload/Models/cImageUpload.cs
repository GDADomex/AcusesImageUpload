using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AcusesImageUpload.Models
{
    public class cImageUpload
    {
        public string Cliente { get; set; }
        [DisplayName ("#Caso")]
        public int ID { get; set; }

        [DisplayName("Imagen Firma")]
        public string ImgPathFirma { get; set; }
        [DisplayName("Imagen Acuse")]
        public string ImgPathAcuse { get; set; }

        [DisplayName("Imagen Acuse")]
        public HttpPostedFile imgFirma { get; set; }
        public HttpPostedFile imgAcuse { get; set; }
    }
}