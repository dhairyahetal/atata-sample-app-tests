﻿using _ = Atata.SampleApp.AutoTests.UsersPage;

namespace Atata.SampleApp.AutoTests
{
    [VerifyTitle]
    public class UsersPage : Page<_>
    {
        public Button<UserEditWindow, _> New { get; private set; }

        public Table<_> Users { get; private set; }

        public class UserTableRow : TableRow<_>
        {
            public Text<_> FirstName { get; private set; }

            public Text<_> LastName { get; private set; }

            public Text<_> Email { get; private set; }

            public Text<_> Office { get; private set; }

            public Link<UserDetailsPage, _> View { get; private set; }

            public Button<UserEditWindow, _> Edit { get; private set; }

            [CloseConfirmBox]
            public Button<_> Delete { get; private set; }
        }
    }
}
