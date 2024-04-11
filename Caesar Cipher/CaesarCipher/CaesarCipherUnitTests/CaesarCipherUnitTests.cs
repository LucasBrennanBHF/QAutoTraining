using CaesarCipherApp;

namespace CaesarCipherUnitTests
{
    public class CaesarCipherUnitTests
    {
        [Theory]
        [InlineData("Caesar Cipher", 3, "Fdhvhu Flskhu")]
        public void GivenAValidString_CaesarCipher_EncryptsIt(string stringToEncrypt, int shiftValue, string expectedResult)
        {
            CaesarCipher _sut = new CaesarCipher();
            Assert.True(_sut.Encrypt(stringToEncrypt, shiftValue) == expectedResult);
        }

        [Theory]
        [InlineData("Fdhvhu Flskhu", 3, "Caesar Cipher")]
        public void GivenAValidString_CaesarCipher_DecryptsIt(string stringToEncrypt, int shiftValue, string expectedResult)
        {
            CaesarCipher _sut = new CaesarCipher();
            Assert.True(_sut.Decrypt(stringToEncrypt, shiftValue) == expectedResult);
        }
    }
}