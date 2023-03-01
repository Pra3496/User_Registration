using RegexProblem;

namespace RegexTests
{
    public class Tests
    {
   
        Regexs regexs= new Regexs();

        const string expect_for_valid = "Valid";
        const string expect_for_not_valid = "Invalid";

        [Test]
        public void Test_For_FirstName_When_Input_Is_Valid()
        {
           string result = regexs.ValidateFirstName("Pranav");

            Assert.AreEqual(expect_for_valid,result);
        }


        [Test]
        public void Test_For_FirstName_When_Input_Is_NOT_Valid_1()
        {
            string result = regexs.ValidateFirstName("pran");

            Assert.AreEqual(expect_for_not_valid, result);
        }

       



    }
}