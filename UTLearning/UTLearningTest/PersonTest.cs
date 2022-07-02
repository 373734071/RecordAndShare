using NUnit.Framework;

namespace UTLearning.Testing
{
	[TestFixture]
	class PersonTest
	{
		[Test]
		public void TestIsValid()
		{
			Assert.AreEqual(false, person.IsValid(2), "< 3");
			Assert.AreEqual(false, person.IsValid(3), "= 3");
			Assert.AreEqual(true, person.IsValid(4), "> 3");
		}


		[SetUp]
		public void SetUp()
		{
			person = new Person();
		}
		Person person;

		[TearDown]
		public void TearDown()
		{
		}
	}
}