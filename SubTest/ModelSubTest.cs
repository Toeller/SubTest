namespace SubTest
{
    internal class ModelSubTest : IModelSubTest
    {
        IViewSubTest IModelSubTest.View { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        IControllerSubTest IModelSubTest.Controller { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}