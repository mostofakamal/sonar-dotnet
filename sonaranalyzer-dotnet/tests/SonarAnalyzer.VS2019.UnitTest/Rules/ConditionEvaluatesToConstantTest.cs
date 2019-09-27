﻿/*
 * SonarAnalyzer for .NET
 * Copyright (C) 2015-2019 SonarSource SA
 * mailto: contact AT sonarsource DOT com
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

extern alias csharp;
using csharp::SonarAnalyzer.Rules.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonarAnalyzer.UnitTest.TestFramework;
using SonarAnalyzer.UnitTest;
using CS = Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;
using SonarAnalyzer.UnitTest2019.TestFramework;

namespace SonarAnalyzer.UnitTest2019.Rules
{
    [TestClass]
    public class ConditionEvaluatesToConstantTest
    {
        [TestMethod]
        [TestCategory("Rule")]
        public void ConditionEvaluatesToConstant_FromCSharp7_2019()
        {
            Verifier.VerifyAnalyzer(@"TestCases\ConditionEvaluatesToConstant.CSharp7.cs",
                new ConditionEvaluatesToConstant(),
                ParseOptionsHelper.CSharp8);
        }
    }
}
