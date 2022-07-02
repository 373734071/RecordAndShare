using NUnit.Framework;

namespace UTLearning.Testing
{
	[TestFixture]
	class PersonTest
	{
		[Test]
		public void TestIsValid()
		{
			Assert.AreEqual(false, person.IsValid(2));
			Assert.AreEqual(false, person.IsValid(3));
			Assert.AreEqual(true, person.IsValid(4));
		}


		[SetUp]
		public void CreateDatabaseObjects()
		{
			person = new Person();
		}
		Person person;

		[TearDown]
		public void DeleteDatabaseObjects()
		{

		}
	}
}