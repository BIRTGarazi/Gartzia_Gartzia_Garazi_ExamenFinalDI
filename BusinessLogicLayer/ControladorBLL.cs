using System;
using System.Collections.Generic;
using DataAccessLayer;
using ObjetosTransferencia.DTO;

namespace BusinessLogicLayer
{
    public static class ControladorBLL
    {

        #region Atributos


        #endregion

        #region Constructores

        #endregion

        #region Propiedades

        #endregion

        #region Metodos


        /// <summary>
        /// Pedir datos de la lista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<ClienteDTO> PedirListaClientes()
        {
            return AccesoDatosDAL.ListadoClientesNorthWind();
        }


        /// <summary>
        /// Pedir la lista de pedidos de un clientelista de clientes a la BD NorthWind SQLServer
        /// </summary>
        public static List<PedidoDTO> ListarPedidosCliente(String nombreCliente)
        {
            return AccesoDatosDAL.ListadoPedidosCliente(nombreCliente);
        }


        #endregion


    }
}
