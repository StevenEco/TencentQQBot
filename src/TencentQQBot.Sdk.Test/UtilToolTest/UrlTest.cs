namespace TencentQQBot.Sdk.Test.UtilToolTest
{
    [TestClass]
    public class UrlTest
    {
        [TestMethod]
        public void UrlArgsTest1()
        {
            (string, string)[] data = { ("name", "alice"), ("age", "18"), ("gender", "female"),("tel","1357") };
            var result = ExtensionFunc.ToParameter(false,data) ;
            Assert.AreEqual("?name=alice&age=18&gender=female&tel=1357", result);
        }
        [TestMethod]
        public void UrlArgsTest2()
        {
            (string, string)[] data = { ("name", "alice"), ("age", "18"), ("gender", "female"), ("tel", "1357") };
            var result = ExtensionFunc.ToParameter(true, data);
            Assert.AreEqual("?Name=alice&Age=18&Gender=female&Tel=1357", result);
        }

    }
}
