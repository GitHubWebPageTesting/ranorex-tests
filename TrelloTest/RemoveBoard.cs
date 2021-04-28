﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TrelloTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RemoveBoard recording.
    /// </summary>
    [TestModule("1501d1c4-0163-4432-8abf-5614449a2de7", ModuleType.Recording, 1)]
    public partial class RemoveBoard : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TrelloTestRepository repository.
        /// </summary>
        public static TrelloTestRepository repo = TrelloTestRepository.Instance;

        static RemoveBoard instance = new RemoveBoard();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RemoveBoard()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RemoveBoard Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BoardWrapperIsShowMenu.ShowMenu' at 56;6.", repo.ApplicationUnderTest.BoardWrapperIsShowMenu.ShowMenuInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BoardWrapperIsShowMenu.ShowMenu.Click("56;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BoardWrapperIsShowMenu.ATagMore' at 108;23.", repo.ApplicationUnderTest.BoardWrapperIsShowMenu.ATagMoreInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.BoardWrapperIsShowMenu.ATagMore.Click("108;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BoardWrapperIsShowMenu.ATagCloseBoard' at 167;28.", repo.ApplicationUnderTest.BoardWrapperIsShowMenu.ATagCloseBoardInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.BoardWrapperIsShowMenu.ATagCloseBoard.Click("167;28");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit' at 212;24.", repo.ApplicationUnderTest.SubmitInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Submit.Click("212;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BoardWrapperIsShowMenu.PermanentlyDeleteBoard' at 187;21.", repo.ApplicationUnderTest.BoardWrapperIsShowMenu.PermanentlyDeleteBoardInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.BoardWrapperIsShowMenu.PermanentlyDeleteBoard.Click("187;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Submit' at 196;21.", repo.ApplicationUnderTest.SubmitInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Submit.Click("196;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.BoardWrapperIsShowMenu.BoardNotFound'.", repo.ApplicationUnderTest.BoardWrapperIsShowMenu.BoardNotFoundInfo, new RecordItemIndex(6));
            Validate.Exists(repo.ApplicationUnderTest.BoardWrapperIsShowMenu.BoardNotFoundInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
