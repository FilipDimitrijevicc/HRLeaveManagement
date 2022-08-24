using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        public Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
