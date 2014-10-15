'==============================================================================

'BSD License
'-----------

'Copyright (c) 2014, and Kevin Fodor, All rights reserved.

'Redistribution and use in source and binary forms, with or without
'modification, are permitted provided that the following conditions are met:

'- Redistributions of source code must retain the above copyright notice,
'this list of conditions and the following disclaimer.

'- Redistributions in binary form must reproduce the above copyright notice,
'this list of conditions and the following disclaimer in the documentation
'and/or other materials provided with the distribution.

'- Neither the name of Kevin Fodor nor the names of
'its contributors may be used to endorse or promote products derived from
'this software without specific prior written permission.

'THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
'AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
'ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE
'LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
'CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
'SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
'INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
'CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
'ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
'POSSIBILITY OF SUCH DAMAGE.

'NOTICE:
'SOME OF THIS CODE MAY HAVE ELEMENTS TAKEN FROM OTHER CODE WITHOUT ATTRIBUTION.
'IF THIS IS THE CASE IT WAS DUE TO OVERSIGHT WHILE DEBUGGING AND I APOLOGIZE.
'IF ANYONE HAS ANY REASON TO BELIEVE THAT ANY OF THIS CODE VIOLATES OTHER
'LICENSES PLEASE CONTACT ME WITH DETAILS SO THAT I MAY CORRECT THE SITUATION.

'==============================================================================

Imports uArm_Controller.Utilities.Ranges

Namespace uArm

    Public Class Range

        ' Base Rotation Value is a 16-bit integer value of 
        ' uArm’s base rotation in degrees.
        ' The valid range is -90 to 90
        Public Shared ReadOnly Rotation As Range(Of Integer) = New Range(Of Integer)(-90, 90, 0)

        ' The Arm Stretch Value is a 16-bit integer value of 
        ' uArm’s stretch away from the base.
        ' The valid range is 0 to 210 decimal
        Public Shared ReadOnly Stretch As Range(Of Integer) = New Range(Of Integer)(0, 210, 0)

        ' The Arm Height Value is a 16-bit integer value of 
        ' uArm’s effector’s height.
        ' The valid range is -180 to 150 decimal.
        Public Shared ReadOnly Height As Range(Of Integer) = New Range(Of Integer)(-180, 150, 0)

        ' The Wrist Rotation Value is a 16-bit integer value of 
        ' uArm’s wrist rotation at the effector in degrees.
        ' The valid range is -90 to 90 decimal.
        Public Shared ReadOnly Wrist As Range(Of Integer) = New Range(Of Integer)(-90, 90, 0)

        ' The Gripper Value is a single bit Boolean
        ' The valid value is either FALSE (Release) or TRUE (Grip)
        Public Shared ReadOnly EffectorState As Range(Of EffectorState) = New Range(Of EffectorState) _
            (uArm.EffectorState.GRIP, uArm.EffectorState.RELEASE, uArm.EffectorState.RELEASE)

    End Class

End Namespace
