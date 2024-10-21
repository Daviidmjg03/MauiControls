using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
   public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get
            {
                return fotos;
            }
            set
            {
                fotos = value; 
            }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() {Nome ="Andronema", ImageUrl="galaxia1.jpg"},
               new Foto() {Nome ="Andronema", ImageUrl="galaxia2.jpg"},
                new Foto() {Nome ="Andronema", ImageUrl="galaxia3.jpg"},
                new Foto() {Nome ="Andronema", ImageUrl="galaxia4.jpg"},
                new Foto() {Nome ="Andronema", ImageUrl="galaxia5.jpg"},

            };
        }
    }
}
