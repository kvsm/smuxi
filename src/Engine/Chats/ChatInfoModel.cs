// Smuxi - Smart MUltipleXed Irc
// 
// Copyright (c) 2011 Mirco Bauer <meebey@meebey.net>
// 
// Full GPL License: <http://www.gnu.org/licenses/gpl.txt>
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307 USA
using System;
using System.Collections.Generic;

namespace Smuxi.Engine
{
    [Serializable]
    public class ChatInfoModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public ChatType ChatType { get; set; }
        public IList<MessageModel> Messages { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime LastSeenHighlight { get; set; }
        public int Position { get; set; }
        public int MessagesSyncCount { get; set; }

        public ChatInfoModel()
        {
        }

        // TODO: implement own serialization with
    }
}
