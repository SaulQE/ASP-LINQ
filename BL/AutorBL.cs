using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class AutorBL
    {
        private BibliotecaEntities bibliotecaDB = new BibliotecaEntities(); 
        public void  Insert(Autore autoreBE) {
            bibliotecaDB.Autores.Add(autoreBE);
            bibliotecaDB.SaveChanges();
        }
        public void Update(Autore autoreBE)
        {
            Autore autorEntity = this.FindById(autoreBE.ID);
            bibliotecaDB.Entry(autorEntity).State=System.Data.Entity.EntityState.Modified;

            bibliotecaDB.Autores.Add(autoreBE);
            bibliotecaDB.SaveChanges();
        }

        public void Delete(int autorId)
        {
            Autore autorDb = this.FindById(autorId);

            bibliotecaDB.Entry(autorDb).State = EntityState.Deleted;
            bibliotecaDB.SaveChanges();
        }


        public Autore FindById(int autorId)
        {
            Autore autoreBE = bibliotecaDB.Autores.Find(autorId);
            return autoreBE;
        }

        public List<Autore> FindAll() 
        { 
            var query = from autores in bibliotecaDB.Autores
                        select autores;

            return query.ToList();
        }

    }
}
