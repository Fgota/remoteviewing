﻿#region License
/*
RemoteViewing VNC Client/Server Library for .NET
Copyright (c) 2013 James F. Bellinger <http://www.zer7.com/software/remoteviewing>
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion

namespace RemoteViewing.Vnc.Server
{
    /// <summary>
    /// Stores information about an update request from the client.
    /// </summary>
    public sealed class FramebufferUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FramebufferUpdateRequest"/> class.
        /// </summary>
        /// <param name="incremental">Whether an incremental update is desired.</param>
        /// <param name="region">The region to update.</param>
        public FramebufferUpdateRequest(bool incremental, VncRectangle region)
        {
            this.Incremental = incremental;
            this.Region = region;
        }

        /// <summary>
        /// Whether an incremental update is desired.
        /// </summary>
        public bool Incremental
        {
            get;
            private set;
        }

        /// <summary>
        /// The region to update.
        /// </summary>
        public VncRectangle Region
        {
            get;
            private set;
        }
    }
}
