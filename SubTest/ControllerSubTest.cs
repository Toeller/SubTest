namespace SubTest
{
    internal class ControllerSubTest : IControllerSubTest
    {
        IModelSubTest IControllerSubTest.Model { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        IViewSubTest IControllerSubTest.View { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}