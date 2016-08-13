﻿//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

namespace DurableTask.Samples.Greetings
{
    using System;
    using System.Windows.Forms;
    using DurableTask;
    using DurableTaskSamples.Greetings;

    public sealed class GetUserTask : TaskActivity<string, string>
    {
        public GetUserTask()
        {
        }

        protected override string Execute(DurableTask.TaskContext context, string input)
        {
            GetUserName userNamedialog = new GetUserName();
            Console.WriteLine("Waiting for user to enter name...");
            string user = "";
            DialogResult dialogResult = userNamedialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                user = userNamedialog.UserName;
            }
            Console.WriteLine("User Name Entered: " + user);

            return user;
        }
    }

}