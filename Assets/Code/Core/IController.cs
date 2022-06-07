namespace Code.Core{
    public interface IController{
        bool IsOn{ get; }
        void Off();
        void On();
    }
}