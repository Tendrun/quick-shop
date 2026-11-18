using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Domain.Features.UserAccounts;

namespace Workshop.Application.Features.UserAccounts {
    public interface IUserAccountService {
        Task<UserAccount?> GetByIdAsync(int id);
    }
}
