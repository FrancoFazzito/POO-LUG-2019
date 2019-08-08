using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_1_S_PUNTO_2
{
    public partial class Form1 : Form
    {
        #region init form
        private Banco banco;
        private enum TiposDeDNI { libretaEnrolamiento, pasaporte, libretaVerde }
        public Form1()
        {
            InitializeComponent();
            banco = new Banco();
            AddEvents();
            COMBO1.DataSource = Enum.GetValues(typeof(TiposDeDNI));
            COMBO2.DataSource = Enum.GetValues(typeof(TiposDeDNI));
        }

        private void AddEvents()
        {
            banco.DepositoEvent += CapturarEventoDeposito;
            banco.ImporteEvent += CapturarEventoImporte;
        }
        private void CapturarEventoDeposito(object mensaje, EventArgs eventArgs)
        {
            MessageBox.Show("evento Deposito:  " + mensaje.ToString());
        }
        private void CapturarEventoImporte(object mensaje, EventArgs eventArgs)
        {
            MessageBox.Show("evento Importe:  " + mensaje.ToString());
        }
        #endregion

        #region EVENTOS
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            banco.AñadirCajaAhorro(Convert.ConvertToDouble(DINERO_CUENTA2),
                                   Convert.ConvertToInt(ID2));
            actualizarCuentaGrid();
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            banco.AñadirCuentaCorriente(Convert.ConvertToDouble(DINERO_DESCUBIERTO1),
                                        Convert.ConvertToDouble(DINERO_CUENTA1),
                                        Convert.ConvertToInt(ID1));
            actualizarCuentaGrid();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            banco.ModificarCuentaCorriente(Convert.ConvertToInt(ID_ORIGEN3),
                                           Convert.ConvertToDouble(DINERO_DESCUBIERTO3),
                                           Convert.ConvertToDouble(DINERO_CUENTA3),
                                           Convert.ConvertToInt(ID_DESTINO3));
            actualizarCuentaGrid();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            banco.EliminarCuentaCorriente(Convert.ConvertToInt(ID4));
            actualizarCuentaGrid();
        }



        private void Button5_Click(object sender, EventArgs e)
        {
            banco.ModificarCajaAhorro(Convert.ConvertToInt(ID5),
                                      Convert.ConvertToDouble(DINERO_CUENTA5),
                                      Convert.ConvertToInt(ID_DESTINO5));
            actualizarCuentaGrid();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            banco.EliminarCajaAhorro(Convert.ConvertToInt(ID6));
            actualizarCuentaGrid();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            banco.TransferenciaCuentaCorriente(Convert.ConvertToInt(ID_ORIGEN7),
                                               Convert.ConvertToDouble(DCANTIDAD_DINERO7),
                                               Convert.ConvertToInt(ID_DESTINO7));
            actualizarCuentaGrid();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            banco.TransferenciaCajaAhorro(Convert.ConvertToInt(ID_ORIGEN8),
                                          Convert.ConvertToDouble(CANTIDAD_DINERO8),
                                          Convert.ConvertToInt(ID_DESTINO8));
            actualizarCuentaGrid();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            banco.Depositar(Convert.ConvertToInt(ID9),
                            Convert.ConvertToDouble(CANTIDAD_DINERO9));
            actualizarCuentaGrid();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            bool resultado = banco.ExtraccionCuentaCorriente(Convert.ConvertToInt(ID10),
                                                             Convert.ConvertToDouble(CANTIDAD_DINERO10));
            try
            {
                if (resultado)
                {
                    actualizarCuentaGrid();
                }
                else
                {
                    throw new ExcepcionExtraccion();
                }
            }
            catch (ExcepcionExtraccion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            bool resultado = banco.ExtraccionCajaAhorro(Convert.ConvertToInt(ID11),
                                                         Convert.ConvertToDouble(CANTIDAD_DINERO11));
            try
            {
                if (resultado)
                {
                    actualizarCuentaGrid();
                }
                else
                {
                    throw new ExcepcionExtraccion();
                }
            }
            catch (ExcepcionExtraccion ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Button12_Click(object sender, EventArgs e)
        {
            banco.AñadirTitularr(Convert.ConvertToString(NOMBRE1),
                                 Convert.ConvertToString(APELLIDO1),
                                 Convert.ConvertToDouble(DNI1),
                                 Convert.convertToStringCombobox(COMBO1));
            actualizarTitularGrid();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            banco.ModificarTitular(Convert.ConvertToDouble(DNI_ORIGEN2),
                                   Convert.ConvertToString(APELLIDO2),
                                   Convert.ConvertToString(NOMBRE2),
                                   Convert.ConvertToDouble(DNI2),
                                   Convert.convertToStringCombobox(COMBO2));
            actualizarTitularGrid();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            banco.EliminarTitular(Convert.ConvertToDouble(DNI3));
            actualizarTitularGrid();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            banco.Añadir_Titular_Cuenta(Convert.ConvertToInt(DNI_TITULAR1),
                                        Convert.ConvertToInt(ID_CUENTA1));
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            banco.Eliminar_Titular_Cuenta(Convert.ConvertToInt(DNI_TITULAR2),
                                          Convert.ConvertToInt(ID_CUENTA2));
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            banco.Añadir_Titular_Cuenta(Convert.ConvertToInt(DNITITULAR1),
                                        Convert.ConvertToInt(IDCUENTA1));
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            banco.Eliminar_Titular_Cuenta(Convert.ConvertToInt(DNITITULAR1),
                                          Convert.ConvertToInt(IDCUENTA1));
        }

        private void GRID_CUENTAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = GRID_CUENTAS.CurrentCell.RowIndex;
                List<Titular> titularesCuentas = banco.GetTitularesDeCuentas(rowindex);
                if (titularesCuentas.Count == 0)
                {
                    throw new Exception();
                }
                GRID_CUENTAS_TITULARES.DataSource = titularesCuentas;
            }
            catch (Exception)
            {
                MessageBox.Show("SE HA SELECCIONADO UNA CUENTA SIN TITULARES");
            }
          
        }

        private void GRID_TITULARES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowindex = GRID_TITULARES.CurrentCell.RowIndex;
                List<Cuenta> cuentasTitulares = banco.GetCuentasDeTitulares(rowindex);
                if(cuentasTitulares.Count == 0)
                {
                    throw new Exception();
                }
                GRID_TITULAR_CUENTA.DataSource = cuentasTitulares;
            }
            catch (Exception)
            {
                MessageBox.Show("SE HA SELECCIONADO UN TITULAR SIN CUENTA");
            }
            
        }
        #endregion

        #region ACTUALIZAR GRILLA
        private void actualizarCuentaGrid()
        {
            GRID_CUENTAS.DataSource = null;
            GRID_CUENTAS.DataSource = banco.GetCuentas();
        }
        private void actualizarTitularGrid()
        {
            GRID_TITULARES.DataSource = null;
            GRID_TITULARES.DataSource = banco.GetTitulares();
        }
        #endregion

        #region EXEPCION EXTRACCION
        class ExcepcionExtraccion : Exception
        {
            public override string Message => "ha ocurrido un error al hacer la Extraccion";
        }
        #endregion
    }
}
