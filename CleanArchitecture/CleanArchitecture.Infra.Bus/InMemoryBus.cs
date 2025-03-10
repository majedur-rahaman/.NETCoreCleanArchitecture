using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Bus
{
    public sealed class InMemoryBus: IMediatorHandler
    {
        private readonly IMediator _iMediator;
        public InMemoryBus(IMediator iMediator)
        {
            _iMediator = iMediator;
        }

        public Task SendCommand<T>(T command) where T: Command
        {
            return _iMediator.Send(command);
        }
    }
}
