using CleanArchitecture.Infrastructure.Common.Security.CurrentUserProvider;
using CleanArchitecture.Infrastructure.Security.CurrentUserProvider;

using TestCommon.TestConstants;

namespace TestCommon.Security;

public class TestCurrentUserProvider : ICurrentUserProvider
{
    private CurrentUser? _currentUser;

    public void Returns(CurrentUser currentUser)
    {
        _currentUser = currentUser;
    }

    public CurrentUser GetCurrentUser() => _currentUser ?? CurrentUserFactory.CreateCurrentUser();
}