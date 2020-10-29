using Imoveis.Business.Models;
using System;
using Xunit;

namespace Imoveis.Test
{
    public class UsuarioTest
    {
        [Fact]
        public void Usuario_DeveCriarAnuncio()
        {
            //arrange
            var usuario = new Usuario(Guid.NewGuid(), "italonleite", "italonleite@gmail.com", "123" );
            var endereco = new Endereco(Guid.NewGuid(), "21210250", "sds", "xyza", "pancas", "es" );
            var imovel = new Imovel(Guid.NewGuid(), "aparatamento xyz", ECaracteristica.COMERCIAL, endereco);

            //act
            var anuncio = usuario.CriarAnuncio(Guid.NewGuid(),10,1,1,1,2,10,100,usuario, imovel);

            //assert
            Assert.NotNull(anuncio);
            Assert.IsType<Anuncio>(anuncio);

        }
        [Fact]
        public void Usuario_NovoUsuario_DeveEstarValido()
        {
            //arrange
            Usuario usuario = new Usuario(Guid.NewGuid(), "italonleite", "italonleite@gmail.com", "123");

            //act
            var result = usuario.EhValido();

            //assert
            Assert.True(result);
        

        }
    }
}
