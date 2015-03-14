using ClotheStore.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClotheStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           /* clothe oclothe = new clothe();
           // oclothe.id = 1;
            oclothe.brand = "Aeropostale";
            oclothe.color = "blank";
            oclothe.name = "short";
            oclothe.size = "m";
            oclothe.url = "www.aeropostale.com/polo/m";*/
           /* ModelClotheStoreContainer oModelClotheStoreContainer = new ModelClotheStoreContainer();
            //oModelClotheStoreContainer.Entry(oclothe).State = System.Data.Entity.EntityState.Added;
            
            oModelClotheStoreContainer.SaveChanges();




            var elemento = oModelClotheStoreContainer.clothe.Where(x=>x.id==2).First();*/




            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums =
                from n in numbers
                where n < 5
                select n;

            //Console.WriteLine("Numbers < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            } 
        }
    }
}
