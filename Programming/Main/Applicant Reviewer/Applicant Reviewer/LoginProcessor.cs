using System.Windows.Forms;
using System.Text.RegularExpressions;
using System;
using System.Globalization;
using System.Linq;

namespace Applicant_Reviewer
{
    class LoginProcessor
    {
        private bool invalid;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="userRights"></param>
        internal void Login(string email, string password, int userRights)
        {
            if (CheckDetails(email, password))
            {
                CheckPrivileges(email, userRights);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        internal bool CheckDetails(string email, string password)
        {
            bool correctLogin = false;

            if ((!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(password)) && (IsValidEmail(email)))
            {
                try
                {
                    using (userEntities test = new userEntities())
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        var query = from o in test.Users where o.email == email && o.password == password
                                    select o;
                        if (query.SingleOrDefault() != null)
                        {
                            correctLogin = true;
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is incorrect.");
                            correctLogin = false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show("Please enter both a valid username, and password");
            return correctLogin;
        }

        /// <summary>
        /// <para>Method to check if email is valid.</para>
        /// <para>&#160;</para>
        /// <para>Reference:</para>
        /// <para>Microsoft, Verify that Strings Are in Valid Email Format [Code].</para>
        /// <para>Available at https://msdn.microsoft.com/en-us/library/01escwtf(v=vs.110).aspx </para>
        /// <para>(Accessed 23 October 2016)</para>
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            invalid = false;
            if (String.IsNullOrEmpty(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;
            
            try
            {
                //Regex expression that checks a match between entered username and the expression (a-zA-Z0-9_-.@a-zA-Z0-9.a-zA-Z
                return Regex.IsMatch(email,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// <para>&#160;</para>
        /// <para>Reference: </para>
        /// <para>Microsoft, Verify that Strings Are in Valid Email Format [Code].</para>
        /// <para>Available at https://msdn.microsoft.com/en-us/library/01escwtf(v=vs.110).aspx </para>
        /// <para>(Accessed 23 October 2016)</para>
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        private string DomainMapper(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

        /// <summary>
        /// Changes PositionOptions.form layout depending on userRights
        /// </summary>
        /// <param name="userRights"></param>
        internal void CheckPrivileges(string email, int userRights)
        {
            switch (userRights)
            {
                case 0:
                    MessageBox.Show("You don't have permission to view this.");
                    break;
                case 1:
                case 2:
                case 3:
                    LoginForm.ActiveForm.Hide();
                    PositionOptions newPositionOptions = new PositionOptions();
                    newPositionOptions.Show();
                    newPositionOptions.CheckVisible(userRights);
                    newPositionOptions.FillDetails(email, userRights);
                    break;
            }
        }
    }
}