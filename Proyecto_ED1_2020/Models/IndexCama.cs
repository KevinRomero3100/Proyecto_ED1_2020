using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_ED1_2020.Models
{
    public class IndexCama
    {
        public string estado { get; set; }
        public string Codigo { get; set; }

        public Queue<IndexCama> hashGUA()
        {
            string codigo = "GUA00";
            Queue<IndexCama> indices = new Queue<IndexCama>();
            for (int i = 1; i <= 10; i++)
            {
                IndexCama index = new IndexCama();
                index.estado = "Disponible";
                index.Codigo = codigo + i;
                indices.Enqueue(index);
            }
            return indices;
        }
        public Queue<IndexCama> hashQUE()
        {
            string codigo = "QUE00";
            Queue<IndexCama> indices = new Queue<IndexCama>();
            for (int i = 1; i <= 10; i++)
            {
                IndexCama index = new IndexCama();
                index.estado = "Disponible";
                index.Codigo = codigo + i;
                indices.Enqueue(index);
            }
            return indices;
        }
        public Queue<IndexCama> hashORI()
        {
            string codigo = "ORI00";
            Queue<IndexCama> indices = new Queue<IndexCama>();
            for (int i = 1; i <= 10; i++)
            {
                IndexCama index = new IndexCama();
                index.estado = "Disponible";
                index.Codigo = codigo + i;
                indices.Enqueue(index);
            }
            return indices;
        }
        public Queue<IndexCama> hashESC()
        {
            string codigo = "ESC00";
            Queue<IndexCama> indices = new Queue<IndexCama>();
            for (int i = 1; i <= 10; i++)
            {
                IndexCama index = new IndexCama();
                index.estado = "Disponible";
                index.Codigo = codigo + i;
                indices.Enqueue(index);
            }
            return indices;
        }
        public Queue<IndexCama> hashPET()
        {
            string codigo = "PET00";
            Queue<IndexCama> indices = new Queue<IndexCama>();
            for (int i = 1; i <= 10; i++)
            {
                IndexCama index = new IndexCama();
                index.estado = "Disponible";
                index.Codigo = codigo + i;
                indices.Enqueue(index);
            }
            return indices;
        }
    }
}