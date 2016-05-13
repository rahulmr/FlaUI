﻿using FlaUI.Core.Elements;
using FlaUI.Core.Identifiers;
using FlaUI.Core.Tools;
using interop.UIAutomationCore;

namespace FlaUI.Core.Patterns
{
    public class SpreadsheetPattern : PatternBase
    {
        public static readonly PatternId Pattern = PatternId.Register(UIA_PatternIds.UIA_SpreadsheetPatternId, "Spreadsheet");

        internal SpreadsheetPattern(AutomationElement automationElement, IUIAutomationSpreadsheetPattern nativePattern)
            : base(automationElement, nativePattern)
        {
        }

        public IUIAutomationSpreadsheetPattern NativePattern
        {
            get { return (IUIAutomationSpreadsheetPattern)base.NativePattern; }
        }

        public AutomationElement GetItemByName(string name)
        {
            var nativeElement = ComCallWrapper.Call(() => NativePattern.GetItemByName(name));
            return ToAutomationElement(nativeElement);
        }
    }
}