using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseUnitTests
{
    [TestClass()]
    public class GetAuthorsByTagIdTests : SqlDatabaseTestClass
    {

        public GetAuthorsByTagIdTests()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ValidTagId_ReturnsAuthors_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetAuthorsByTagIdTests));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Row1Column1IsMarkSeemannsId;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Row1Column2IsMarkSeemannsName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Row2Column1IsStevenVanDeursensId;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Row2Column2IsStevenVanDeursensName;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ValidTagId_ReturnsAuthors_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ValidTagId_ReturnsAuthors_PosttestAction;
            this.ValidTagId_ReturnsAuthorsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            ValidTagId_ReturnsAuthors_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Row1Column1IsMarkSeemannsId = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Row1Column2IsMarkSeemannsName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Row2Column1IsStevenVanDeursensId = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Row2Column2IsStevenVanDeursensName = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ValidTagId_ReturnsAuthors_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ValidTagId_ReturnsAuthors_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // ValidTagId_ReturnsAuthors_TestAction
            // 
            ValidTagId_ReturnsAuthors_TestAction.Conditions.Add(Row1Column1IsMarkSeemannsId);
            ValidTagId_ReturnsAuthors_TestAction.Conditions.Add(Row1Column2IsMarkSeemannsName);
            ValidTagId_ReturnsAuthors_TestAction.Conditions.Add(Row2Column1IsStevenVanDeursensId);
            ValidTagId_ReturnsAuthors_TestAction.Conditions.Add(Row2Column2IsStevenVanDeursensName);
            resources.ApplyResources(ValidTagId_ReturnsAuthors_TestAction, "ValidTagId_ReturnsAuthors_TestAction");
            // 
            // Row1Column1IsMarkSeemannsId
            // 
            Row1Column1IsMarkSeemannsId.ColumnNumber = 1;
            Row1Column1IsMarkSeemannsId.Enabled = true;
            Row1Column1IsMarkSeemannsId.ExpectedValue = "2419A00A-8D33-45F9-9A87-778729CCCEE6";
            Row1Column1IsMarkSeemannsId.Name = "Row1Column1IsMarkSeemannsId";
            Row1Column1IsMarkSeemannsId.NullExpected = false;
            Row1Column1IsMarkSeemannsId.ResultSet = 1;
            Row1Column1IsMarkSeemannsId.RowNumber = 1;
            // 
            // Row1Column2IsMarkSeemannsName
            // 
            Row1Column2IsMarkSeemannsName.ColumnNumber = 2;
            Row1Column2IsMarkSeemannsName.Enabled = true;
            Row1Column2IsMarkSeemannsName.ExpectedValue = "Mark Seemann";
            Row1Column2IsMarkSeemannsName.Name = "Row1Column2IsMarkSeemannsName";
            Row1Column2IsMarkSeemannsName.NullExpected = false;
            Row1Column2IsMarkSeemannsName.ResultSet = 1;
            Row1Column2IsMarkSeemannsName.RowNumber = 1;
            // 
            // Row2Column1IsStevenVanDeursensId
            // 
            Row2Column1IsStevenVanDeursensId.ColumnNumber = 1;
            Row2Column1IsStevenVanDeursensId.Enabled = true;
            Row2Column1IsStevenVanDeursensId.ExpectedValue = "075585F3-B560-413D-8152-ADE735E2AA4E";
            Row2Column1IsStevenVanDeursensId.Name = "Row2Column1IsStevenVanDeursensId";
            Row2Column1IsStevenVanDeursensId.NullExpected = false;
            Row2Column1IsStevenVanDeursensId.ResultSet = 1;
            Row2Column1IsStevenVanDeursensId.RowNumber = 2;
            // 
            // Row2Column2IsStevenVanDeursensName
            // 
            Row2Column2IsStevenVanDeursensName.ColumnNumber = 2;
            Row2Column2IsStevenVanDeursensName.Enabled = true;
            Row2Column2IsStevenVanDeursensName.ExpectedValue = "Steven van Deursen";
            Row2Column2IsStevenVanDeursensName.Name = "Row2Column2IsStevenVanDeursensName";
            Row2Column2IsStevenVanDeursensName.NullExpected = false;
            Row2Column2IsStevenVanDeursensName.ResultSet = 1;
            Row2Column2IsStevenVanDeursensName.RowNumber = 2;
            // 
            // ValidTagId_ReturnsAuthorsData
            // 
            this.ValidTagId_ReturnsAuthorsData.PosttestAction = ValidTagId_ReturnsAuthors_PosttestAction;
            this.ValidTagId_ReturnsAuthorsData.PretestAction = ValidTagId_ReturnsAuthors_PretestAction;
            this.ValidTagId_ReturnsAuthorsData.TestAction = ValidTagId_ReturnsAuthors_TestAction;
            // 
            // ValidTagId_ReturnsAuthors_PretestAction
            // 
            resources.ApplyResources(ValidTagId_ReturnsAuthors_PretestAction, "ValidTagId_ReturnsAuthors_PretestAction");
            // 
            // ValidTagId_ReturnsAuthors_PosttestAction
            // 
            resources.ApplyResources(ValidTagId_ReturnsAuthors_PosttestAction, "ValidTagId_ReturnsAuthors_PosttestAction");
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void ValidTagId_ReturnsAuthors()
        {
            SqlDatabaseTestActions testActions = this.ValidTagId_ReturnsAuthorsData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions ValidTagId_ReturnsAuthorsData;
    }
}
