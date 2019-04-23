using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using Logica;

namespace Eventos.Tests
{
    [TestClass]
    public class EventoTest
    {
        [TestMethod]
        public void CargaExcelTest()
        {
            Entidades.Padron esperado = new Entidades.Padron()
            {
                id = "00000111",
                Nombre = "GONZALEZ QUIROS PAOLA DANIELA               ",
                Cedula = "111111222",
                Estatus1 = "Activo",
                Estado2 = "Confirmado",
                Correo = "1ab@utn.ac.cr",
                Telefono = "8888-88-19",
                idEvento = 1
            };

            Logica.PadronL.Nuevo("I", "D:\\Universidad\\UTN\\2019\\I Cuatrimestre\\ProyectoEventos\\Eventos\\Archivos\\Padron Asociados.xlsx", "1");
            List<Entidades.Padron> lstPadron = Logica.PadronL.ObtenerTodos();
            Entidades.Padron resultado = new Entidades.Padron();
            foreach (Entidades.Padron pa in lstPadron)
            {
                resultado.Cedula = pa.Cedula;
                resultado.Correo = pa.Correo;
                resultado.Estado2 = pa.Estado2;
                resultado.Estatus1 = pa.Estatus1;
                resultado.id = pa.id;
                resultado.idEvento = pa.idEvento;
                resultado.Nombre = pa.Nombre;
                resultado.Telefono = pa.Telefono;
            }

            Assert.AreEqual(esperado.Cedula, resultado.Cedula);
            Assert.AreEqual(esperado.Correo, resultado.Correo);
            Assert.AreEqual(esperado.Estado2, resultado.Estado2);
            Assert.AreEqual(esperado.Estatus1, resultado.Estatus1);
            Assert.AreEqual(esperado.id, resultado.id);
            Assert.AreEqual(esperado.idEvento, resultado.idEvento);
            Assert.AreEqual(esperado.Nombre, resultado.Nombre);
            Assert.AreEqual(esperado.Telefono, resultado.Telefono);
        }


        [TestMethod]
        public void Login()
        {
            Usuario user = new Usuario()
            {
                id = "207350408",
                contrasenna = "12345"
            };

            Usuario esperado = new Usuario()
            {
                id="207350408",
                Nombre = "Luis Ledezma",
                contrasenna = "12345",
                Estado = 1,
                idPerfil=1
            };
            Usuario obtenido = new UsuarioL().SeleccionarUsuario(user);
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod]
        public void InsertarUsuario()
        {
            Usuario user = new Usuario();
            user.id = "207350408";
            user.Nombre = "Luis Ledezma";
            user.contrasenna = "12345";
            user.idPerfil = 1;
            user.Estado = 1;

            UsuarioL.Nuevo(user, "I");
            Usuario obtenido = new UsuarioL().SeleccionarUsuario(user);

            Assert.AreEqual(user, obtenido);
            

        }


        public void InsertarEvento()
        {
            Evento miEvento = new Evento()
            {
                id = "",
                Nombre = "evento1",
                Fecha = DateTime.Now,
                Estado = 'A'
            };

            EventoL.Nuevo(miEvento, "I");

            List<Evento> list = EventoL.ObtenerTodos();
            Evento obtenido = (from p in list where p.Nombre = miEvento.Nombre select p);
            Assert.AreEqual(miEvento, obtenido);
        }



    }
}
