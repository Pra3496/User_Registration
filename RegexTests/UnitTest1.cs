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



        /////  Last Name Validation

        [Test]
        public void Test_For_LastName_When_Input_Is_Valid()
        {
            string result = regexs.ValidateLastName("Waghmare");

            Assert.AreEqual(expect_for_valid, result);
        }


        [Test]
        public void Test_For_LastName_When_Input_Is_NOT_Valid1()
        {
            string result = regexs.ValidateLastName("wg");

            Assert.AreEqual(expect_for_not_valid, result);
        }


        ////// Email Validation Test
        ///

        [Test]
        public void Test_For_Email_When_Input_Is_Valid()
        {
            string result = regexs.ValidateEmail("abc.xyz@bridgelabz.co.in");

            Assert.AreEqual(expect_for_valid, result);
        }

        [Test]
        public void Test_For_Email_When_Input_Is_NOT_Valid1()
        {
            string result = regexs.ValidateEmail("abc.xyzbridgelabz.co.in");

            Assert.AreEqual(expect_for_not_valid, result);
        }



        ////// Phone Number Validation Test
        ///

        [Test]
        public void Test_For_Phone_Number_When_Input_Is_Valid()
        {
            string result = regexs.ValidatePhoneNumber("91 9136251232");

            Assert.AreEqual(expect_for_valid, result);
        }

        [Test]
        public void Test_For_Phone_Number_When_Input_Is_NOT_Valid1()
        {
            string result = regexs.ValidatePhoneNumber("91 9ot6251232");

            Assert.AreEqual(expect_for_not_valid, result);
        }



        ////// Password Minimum 8 Chrecters Validation Test
        ///

        [Test]
        public void Test_For_Password_When_Input_Is_Valid()
        {
            string result = regexs.ValidatePassword("pranavwg");

            Assert.AreEqual(expect_for_valid, result);
        }


        [Test]
        public void Test_For_Password_When_Input_Is_NOT_Valid1()
        {
            string result = regexs.ValidatePassword("pranavw");

            Assert.AreEqual(expect_for_not_valid, result);
        }


        //////   Password Atleast one UpperCase Chrecters Validation Test

        [Test]
        public void Test_For_Password_AtleastOneUpperCase_When_Input_Is_Valid()
        {
            string result = regexs.ValidateStringUpperCasePassword("praNav");

            Assert.AreEqual(expect_for_valid, result);
        }

        [Test]
        public void Test_For_Password_AtleastOneUpperCase_When_Input_Is_Not_Valid1()
        {
            string result = regexs.ValidateStringUpperCasePassword("pranav");

            Assert.AreEqual(expect_for_not_valid, result);
        }

        ////// Password Atleast one Numeric Validation Test
        ///

        [Test]
        public void Test_For_Password_AtleastOneNumeric_When_Input_Is_Valid()
        {
            string result = regexs.ValidateNumericPassword("pranav1");

            Assert.AreEqual(expect_for_valid, result);
        }

        [Test]
        public void Test_For_Password_AtleastOneNumeric_When_Input_Is_Not_Valid1()
        {
            string result = regexs.ValidateNumericPassword("pranan");

            Assert.AreEqual(expect_for_not_valid, result);
        }


        ////// Password Atleast one Special Charecter Validation Test
        ///

        [Test]
        public void Test_For_Password_AtleastOne_SpecialCharecter_When_Input_Is_Valid()
        {
            string result = regexs.ValidateSpecialCharacter("Pra@123");

            Assert.AreEqual(expect_for_valid, result);
        }



        [Test]
        public void Test_For_Password_AtleastOne_SpecialCharecter_When_Input_Is_Not_Valid1()
        {
            string result = regexs.ValidateSpecialCharacter("pranav");

            Assert.AreEqual(expect_for_not_valid, result);
        }

    }
}