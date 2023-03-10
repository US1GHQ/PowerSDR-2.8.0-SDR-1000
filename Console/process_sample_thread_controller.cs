//=================================================================
// process_sample_thread_controller.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2003-2013  FlexRadio Systems
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// You may contact us via email at: gpl@flexradio.com.
// Paper mail may be sent to: 
//    FlexRadio Systems
//    4616 W. Howard Lane  Suite 1-150
//    Austin, TX 78728
//    USA
//=================================================================

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text;
using System.Windows.Forms;

namespace PowerSDR
{
    public class ProcessSampleThreadController
    {
        uint thread;
        public ProcessSampleThreadController(uint threadno)
        {
            this.thread = threadno;
        }

        //private static int next_cpu = 1;

        public void ProcessSampleThread()
        {
            /*Thread.BeginThreadAffinity();
            int id = AppDomain.GetCurrentThreadId();
            int num_cpus = Environment.ProcessorCount;

            ProcessThreadCollection threads = Process.GetCurrentProcess().Threads;
            for (int i = 0; i < threads.Count; i++)
            {
                if (threads[i].Id == id)
                {
                    threads[i].ProcessorAffinity = (IntPtr)next_cpu;
                    Thread.EndThreadAffinity();
                    //next_cpu++;
                    //if (next_cpu > num_cpus)
                    //    next_cpu = 1;
                    break;
                }
            }*/

            DttSP.ProcessSamplesThread(thread);
        }
    }
}