using Semana4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Semana4.ViewModel
{
    public class ManCategoriaViewModel : ViewModelBase
    {

        int _ID;

        public int ID
        {
            get { return _ID; }
            set
            {
                if(_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre != value)
                {
                    _Nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if (_Descripcion != value)
                {
                    _Descripcion = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand GrabarCommand { set; get; }
        public ICommand CerrarCommand { set; get; }
        public ICommand EliminarCommand { set; get; }

        public ManCategoriaViewModel()
        {
            GrabarCommand = new RelayCommand<Window>(
                
                param =>
                {
                    if (ID > 0)
                        new CategoriaModel().Actualizar(new Entity.Categoria
                        {
                            IdCategoria = ID,
                            NombreCategoria = Nombre,
                            Descripcion = Descripcion
                        });

                    else
                        new CategoriaModel().Insertar(new Entity.Categoria
                        {
                            NombreCategoria = Nombre,
                            Descripcion = Descripcion
                        });
                    CerrarCommand.Execute(param);
                });

            EliminarCommand = new RelayCommand<Window>(
                    new CategoriaModel().Eliminar(ID)
                );

            CerrarCommand = new RelayCommand<Window>(
                param => Cerrar(param)
                );
        }

        void Cerrar(Window window)
        {
            window.Close();
        }

    }
}
