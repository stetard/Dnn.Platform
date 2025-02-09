﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.DDRMenu.TemplateEngine
{
    public class ClientNumber : ClientOption
    {
        public ClientNumber()
        {
        }

        public ClientNumber(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
