﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAllocationGenerator.Utils.Constants;

namespace TaskAllocationGenerator.Utils.Classes
{
    /// <summary>
    /// The class provides the number of tasks,
    /// the number of processors and the maximum duration
    /// </summary>
    public class ProgramInfo
    {
        public double Duration { get; set; }
        public int Tasks { get; set; }
        public int Processors { get; set; }

        public ProgramInfo()
        {
            Duration = -1;
            Tasks = -1;
            Processors = -1;
        }

        public ProgramInfo(double duration, int tasks, int processors)
        {
            Duration = duration;
            Tasks = tasks;
            Processors = processors;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine($"PROGRAM-{CffKeywords.PROGRAM_DURATION}={Duration}");
            text.AppendLine($"PROGRAM-{CffKeywords.PROGRAM_TASKS}={Tasks}");
            text.AppendLine($"PROGRAM-{CffKeywords.PROGRAM_PROCESSORS}={Processors}");

            return text.ToString();
        }
    }
}
