using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace CourseProfileUI.ViewModels
{
    public class CourseProfileViewModel
    {
        public ObservableCollection<HomeWork> homeWorks { get; set; }

        public CourseProfileViewModel()
        {
            homeWorks = new ObservableCollection<HomeWork>()
            {
                new HomeWork { FileName = "Documentación Técnica.docx" },
                new HomeWork { FileName = "Imagenes De Articulos.docx" },
                new HomeWork { FileName = "Diseño Funcional.docx" },
                new HomeWork { FileName = "Diseño Técnico II.docx" }
            };
        }
    }

}
