using System;
using UniRx;


namespace Code.Core{
    public abstract class BaseController : IController, IDisposable{
        protected CompositeDisposable _subscriptions = new CompositeDisposable();
        
        public bool IsOn{ get; private set; } = false;

        public event Action OnEnable = () => { };
        public event Action OnDisable = () => { };

        public void Off(){
            IsOn = false;
            OnDisable?.Invoke();
        }

        public void On(){
            IsOn = true;
            OnEnable?.Invoke();
        }

        public abstract void Init();

        public virtual void Dispose(){
            _subscriptions?.Dispose();
        }
    }
}