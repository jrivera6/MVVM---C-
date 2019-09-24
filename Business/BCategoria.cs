using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BCategoria
    {
        private DCategoria DCategoria = null;

        public List<Categoria> Listar(int IdCategoria)
        {
            List<Categoria> categorias = null;

            try
            {
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = IdCategoria });
            }
            catch (Exception e)
            {
                throw e;
            }
            return categorias;
        }

        public bool Insertar(Categoria categoria)
        {
            bool result = true;
            List<Categoria> categorias = null;
            int IdNextCategoria = 0;
            try
            {
                categorias = new List<Categoria>();
                DCategoria = new DCategoria();
                categorias = DCategoria.Listar(new Categoria { IdCategoria = 0 });
                IdNextCategoria = categorias.Max(x => x.IdCategoria)+1;
                categoria.IdCategoria = IdNextCategoria;
                DCategoria.Insertar(categoria);
            }
            catch (Exception e)
            {
                result = false;
            }
            return result;
        }
       

        public bool Actualizar(Categoria categoria)
        {
            bool result = true;

            try
            {
                DCategoria = new DCategoria();
                DCategoria.Actualizar(categoria);
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

        public bool Eliminar(int IdCategoria)
        {
            bool result = true;

            try
            {
                DCategoria = new DCategoria();
                DCategoria.Eliminar(IdCategoria);
            }
            catch (Exception e)
            {
                result = false;
            }

            return result;
        }

    }
}
