﻿using System;


namespace OpenVIII.Fields.Scripts.Instructions
{
    internal sealed class SETODIN : JsmInstruction
    {
        public SETODIN()
        {
        }

        public SETODIN(Int32 parameter, IStack<IJsmExpression> stack)
            : this()
        {
        }

        public override String ToString()
        {
            return $"{nameof(SETODIN)}()";
        }
    }
}