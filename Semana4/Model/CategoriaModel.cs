using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Business;

namespace Semana4.Model
{
    class CategoriaModel
    {

        public ObservableCollection<Categoria> Categorias { get; set; }

        public bool Insertar(Categoria categoria)
        {
            return (new BCategoria()).Insertar(categoria);
        }

        public bool Actualizar(Categoria categoria)
        {
            return (new BCategoria()).Actualizar(categoria);
        }

        public bool Eliminar(int id)
        {
            return (new BCategoria()).Eliminar(id);
        }

        public CategoriaModel()
        {
            var lista = (new BCategoria().Listar(0));
            Categorias = new ObservableCollection<Categoria>(lista);
        }

    }
}
