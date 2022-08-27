using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    internal class RelayCommandAsync : CommandBase
    {
        private readonly ActionAsync<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public RelayCommandAsync(ActionAsync Execute, Func<bool> CanExecute = null)
            : this(async p => await Execute(), CanExecute is null ? (Func<object, bool>)null : p => CanExecute())
        {

        }

        public RelayCommandAsync(ActionAsync<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute;
            _CanExecute = CanExecute;
        }

        protected override bool CanExecute(object p) => _CanExecute?.Invoke(p) ?? true;

        protected override void Execute(object p) => _Execute(p);
    }
}
