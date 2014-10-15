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

Imports System.Windows.Forms

Public Class uArmJoystickDialog

    Inherits JoystickDialog

    Private _controller_list As New List(Of Controller)
    Private _obj_list As New List(Of JoystickObjects)

    Friend WithEvents ControllerContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ButtonsContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AxisContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PovContextMenuStrip As System.Windows.Forms.ContextMenuStrip

    Sub New(Optional ByVal guid As System.Guid = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AbsoluteModeRadioButton.Checked = My.Settings.AbsoluteMode
        RelativeModeRadioButton.Checked = Not My.Settings.AbsoluteMode

        ' Context Menus

        ControllerContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        ButtonsContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        AxisContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        PovContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)

        ' Build controller list

        Try
            ' Make sure that DirectInput has been initialized
            Dim dInput As New DirectInput()

            ' Clear Tree
            uArmTreeView.Nodes.Clear()

            ' Build controller list
            Dim controller_node As TreeNode

            ' Populate a list of 'Game Controllers'
            For Each device As DeviceInstance In dInput.GetDevices( _
                DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly)

                Dim controller As Controller = New Controller
                controller.Name = device.ProductName
                controller.GUID = device.ProductGuid
                _controller_list.Add(controller)

                controller_node = New TreeNode(controller.Name)
                controller_node.Tag = controller.GUID
                Me.uArmTreeView.Nodes.Add(controller_node)

                PopulateArm(Me.uArmTreeView.Nodes(0).Nodes)

            Next device

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
            ParentForm.Close()
        End Try

    End Sub

    Sub PopulateArm(ByRef item As TreeNodeCollection)

        ' Build uArm list
        Dim state As uArm.State = New uArm.State

        ' Start off by adding a base treeview node
        Dim uarm_node As New TreeNode("uArm(" & state.Parts.Count & ")")
        uarm_node.Name = "uArmNode"
        item.Add(uarm_node)

        ' Populate a list of 'uarm parts'
        For Each part As uArm.Parameter In state.Parts
            Dim part_node = New TreeNode(part.Name)
            part_node.Tag = part
            part_node.ContextMenuStrip = ControlContextMenuStrip
            uarm_node.Nodes.Add(part_node)
        Next


    End Sub

    Protected Overrides Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.AbsoluteMode = AbsoluteModeRadioButton.Checked
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub uArmJoystickDialog_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '' Clear Tree
        'uArmTreeView.Nodes.Clear()

        '' start off by adding a base treeview node
        'Dim mainNode As New TreeNode()
        'mainNode.Name = "uArmNode"
        'mainNode.Text = "uArm"
        'Me.uArmTreeView.Nodes.Add(mainNode)

        '' Build controller list
        'Dim controller_node As TreeNode
        'For Each controller As Controller In _controller_list
        '    controller_node = New TreeNode(controller.Name)
        '    controller_node.Tag = controller.GUID
        '    Me.uArmTreeView.Nodes(0).Nodes.Add(controller_node)

        '' Build list of controls
        'Dim control_node As TreeNode

        'control_node = New TreeNode("Axis (" & _axis_list.Count & ")")
        'controller_node.Nodes.Add(control_node)
        'For Each axis As Axis In _axis_list
        '    Dim axis_node As TreeNode = New TreeNode(axis.Name)
        '    axis_node.Tag = axis
        '    axis_node.ContextMenuStrip = ControlContextMenuStrip
        '    control_node.Nodes.Add(axis_node)
        'Next
        'control_node = New TreeNode("Buttons (" & _obj_list.Count & ")")
        'controller_node.Nodes.Add(control_node)
        'For Each button As Button In _obj_list
        '    Dim button_node As TreeNode = New TreeNode(button.Name)
        '    button_node.Tag = button
        '    button_node.ContextMenuStrip = ControlContextMenuStrip
        '    control_node.Nodes.Add(button_node)
        'Next
        'control_node = New TreeNode("POV (" & _pov_list.Count & ")")
        'controller_node.Nodes.Add(control_node)
        'For Each pov As POV In _pov_list
        '    Dim pov_node As TreeNode = New TreeNode(pov.Name)
        '    pov_node.Tag = pov
        '    pov_node.ContextMenuStrip = ControlContextMenuStrip
        '    control_node.Nodes.Add(pov_node)
        'Next
        'Next

        uArmTreeView.ExpandAll()

    End Sub

#Region "Dead"

    'Private Sub AddControlHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Cast the tool strip menu item clicked
    '    Dim tsi As ToolStripMenuItem
    '    tsi = CType(sender, ToolStripMenuItem)

    '    ' Find the button this item represents
    '    Dim button As Button
    '    button = _button_list.Find(Function(b) b.Name.Contains(tsi.Text))

    '    ' Create a button nodes set for edit/remove
    '    Dim button_nodes As TreeNode
    '    button_nodes = ControlEditRemoveNodes(button)

    '    ' Add the new nodes
    '    uArmTreeView.SelectedNode.Nodes.Add(button_nodes)
    '    'AddHandler button_nodes, AddressOf ControlContextMenuHandler
    'End Sub


    'Private Sub AddButtonHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Cast the tool strip menu item clicked
    '    Dim tsi As ToolStripMenuItem
    '    tsi = CType(sender, ToolStripMenuItem)

    '    ' Find the button this item represents
    '    Dim button As Button
    '    button = _button_list.Find(Function(b) b.Name.Contains(tsi.Text))

    '    ' Create a button nodes set for edit/remove
    '    Dim button_nodes As TreeNode
    '    button_nodes = ControlEditRemoveNodes(button)

    '    ' Add the new nodes
    '    uArmTreeView.SelectedNode.Nodes.Add(button_nodes)
    '    'AddHandler button_nodes, AddressOf ControlContextMenuHandler
    'End Sub

    'Private Sub AddAxisHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Cast the tool strip menu item clicked
    '    Dim tsi As ToolStripMenuItem
    '    tsi = CType(sender, ToolStripMenuItem)

    '    ' Find the axis this item represents
    '    Dim axis As Axis
    '    axis = _axis_list.Find(Function(b) b.Name.Contains(tsi.Text))

    '    ' Create a button nodes set for edit/remove
    '    Dim button_nodes As TreeNode
    '    button_nodes = ControlEditRemoveNodes(axis)

    '    ' Add the new nodes
    '    uArmTreeView.SelectedNode.Nodes.Add(button_nodes)
    'End Sub

    'Private Sub AddPovHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim tsi As ToolStripMenuItem
    '    tsi = CType(sender, ToolStripMenuItem)
    '    MessageBox.Show("POV: " & tsi.Text)

    'End Sub

    'Function ControlEditRemoveNodes(obj As DirectInputObjects) As TreeNode

    '    Dim control_edit_remove_treenode As TreeNode = New TreeNode(obj.Name)

    '    control_edit_remove_treenode.ContextMenuStrip = ControlEditContextMenuStrip
    '    control_edit_remove_treenode.Name = "ControlEditRemoveNode"
    '    control_edit_remove_treenode.Text = obj.Name

    '    Dim child As TreeNode
    '    child = control_edit_remove_treenode.Nodes.Add("Name: " & obj.Name)

    '    If GetType(Button) = obj.GetType() Then
    '        Dim button As Button = CType(obj, Button)
    '        child = control_edit_remove_treenode.Nodes.Add("Index: " & button.Index)
    '    ElseIf GetType(Axis) = obj.GetType() Then
    '        Dim axis As Axis = CType(obj, Axis)
    '        child = control_edit_remove_treenode.Nodes.Add("Index: " & axis.Index)
    '    ElseIf GetType(POV) = obj.GetType() Then

    '        Dim pov As POV = CType(obj, POV)
    '        child = control_edit_remove_treenode.Nodes.Add("Index: " & pov.Index)

    '    End If

    '    'AddHandler control_edit_remove_treenode.ContextMenuStrip.ItemClicked, AddressOf ControlContextMenuHandler

    '    Return control_edit_remove_treenode
    'End Function

    'Private Sub ControlContextMenuHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim cms As ContextMenuStrip = CType(sender, ContextMenuStrip)
    '    Dim item As ToolStripItemClickedEventArgs = CType(e, ToolStripItemClickedEventArgs)
    '    If item.ClickedItem.Text = "Edit" Then
    '        Dim dlg As ButtonConfigDialog = New ButtonConfigDialog
    '        dlg.Show()
    '    ElseIf item.ClickedItem.Text = "Remove" Then
    '        If Not uArmTreeView.SelectedNode Is Nothing Then
    '            uArmTreeView.SelectedNode.Remove()
    '        End If
    '    End If
    'End Sub

    'Private Sub AddButtonToolStripMenuItem_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles RotationToolStripMenuItem.Click
    '    ' Cast the tool strip menu item clicked
    '    Dim tsi As ToolStripMenuItem
    '    tsi = CType(sender, ToolStripMenuItem)

    '    ' Find the button this item represents
    '    Dim button As Button
    '    button = _button_list.Find(Function(b) b.Name.Contains(tsi.Text))

    '    ' Create a button nodes set for edit/remove
    '    Dim button_nodes As TreeNode
    '    button_nodes = ControlEditRemoveNodes(button)

    '    ' Add the new nodes
    '    uArmTreeView.SelectedNode.Nodes.Add(button_nodes)
    'End Sub

    'Private Sub AddAxisToolStripMenuItem_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles StretchToolStripMenuItem.Click
    '    ' Cast the tool strip menu item clicked
    '    Dim tsi As ToolStripMenuItem
    '    tsi = CType(sender, ToolStripMenuItem)

    '    ' Find the axis this item represents
    '    Dim axis As Axis
    '    axis = _axis_list.Find(Function(b) b.Name.Contains(tsi.Text))

    '    ' Create a button nodes set for edit/remove
    '    Dim axis_nodes As TreeNode
    '    axis_nodes = ControlEditRemoveNodes(axis)

    '    ' Add the new nodes
    '    uArmTreeView.SelectedNode.Nodes.Add(axis_nodes)
    'End Sub

    'Private Sub AddPovToolStripMenuItem_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles HeightToolStripMenuItem.Click
    'End Sub


    'Private Sub uArmTreeView_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles uArmTreeView.AfterSelect
    '    Label1.Text = uArmTreeView.SelectedNode.FullPath
    'End Sub

    'Private Sub uArmTreeView_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles uArmTreeView.Click
    '   Label1.Text = uArmTreeView.SelectedNode.FullPath
    'End Sub

    'Private Sub cmnuAddNode_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles control_edit_remove_treenode.Click

    '    'Dim n As New Form2()
    '    'n.ShowDialog()
    '    Dim nod As New TreeNode()
    '    nod.Name = "TestADD" 'n.NewNodeName.ToString()
    '    'nod.Text = n.NewNodeText.ToString()
    '    'nod.Tag = n.NewNodeTag.ToString()
    '    'n.Close()

    '    uArmTreeView.SelectedNode.Nodes.Add(nod)
    '    uArmTreeView.SelectedNode.ExpandAll()

    'End Sub

    'Private Sub cmnuRemoveNode_Click(ByVal sender As System.Object, _
    '    ByVal e As System.EventArgs) Handles cmnuRemoveNode.Click

    '    uArmTreeView.SelectedNode.Remove()

    'End Sub

    '' Add objects

    '' Retrieve the joystick by  GUID
    'Dim joystick = New SlimDX.DirectInput.Joystick(dInput, Device.ProductGuid)

    '' Build list of controls
    'Dim control_node As TreeNode

    '' Scrape through all available joystick objects
    '            For Each deviceObject As DeviceObjectInstance In joystick.GetObjects()

    '                If deviceObject.ObjectTypeGuid = ObjectGuid.Button Then

    '                    control_node = New TreeNode("Buttons (" & _obj_list.Count & ")")
    '                    controller_node.Nodes.Add(control_node)

    'Dim button As Button = New Button(deviceObject.Usage - 1, deviceObject.Name)
    '                    _obj_list.Add(button)

    'Dim button_node As TreeNode = New TreeNode(Button.Name)
    '                    button_node.Tag = button
    '                    button_node.ContextMenuStrip = ControlContextMenuStrip
    '                    control_node.Nodes.Add(button_node)

    '                ElseIf deviceObject.ObjectTypeGuid = ObjectGuid.XAxis _
    '                Or deviceObject.ObjectTypeGuid = ObjectGuid.YAxis _
    '                    Or deviceObject.ObjectTypeGuid = ObjectGuid.ZAxis Then

    '                    control_node = New TreeNode("Axis (" & _obj_list.Count & ")")
    '                    controller_node.Nodes.Add(control_node)

    'Dim axis As Axis = New Axis(deviceObject.Usage - 1, deviceObject.Name)
    '                    _obj_list.Add(axis)

    'Dim axis_node As TreeNode = New TreeNode(Axis.Name)
    '                    axis_node.Tag = axis
    '                    axis_node.ContextMenuStrip = ControlContextMenuStrip
    '                    control_node.Nodes.Add(axis_node)

    '                ElseIf deviceObject.ObjectTypeGuid = ObjectGuid.PovController Then

    '                    control_node = New TreeNode("POV (" & _obj_list.Count & ")")
    '                    controller_node.Nodes.Add(control_node)

    'Dim pov As POV = New POV(deviceObject.Usage - 1, deviceObject.Name)
    '                    _obj_list.Add(pov)

    'Dim pov_node As TreeNode = New TreeNode(POV.Name)
    '                    pov_node.Tag = pov
    '                    pov_node.ContextMenuStrip = ControlContextMenuStrip
    '                    control_node.Nodes.Add(pov_node)
    '                End If
    '            Next deviceObject

#End Region

#Region "Treeview Event Handlers"

    Private Sub uArmTreeView_MouseUp(ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) _
        Handles uArmTreeView.MouseUp
        ' Show menu only if Right Mouse button is clicked
        If e.Button = MouseButtons.Right Then
            ' Point where mouse is clicked
            Dim p As Point = New Point(e.X, e.Y)

            ' Go to the node that the user clicked
            Dim node As TreeNode = uArmTreeView.GetNodeAt(p)
            If Not node Is Nothing Then
                ' Highlight the selected node
                uArmTreeView.SelectedNode = node
            End If
        End If
    End Sub

    Private Sub RemoveAllToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RemoveAllToolStripMenuItem.Click
        uArmTreeView.SelectedNode.Nodes.Clear()
    End Sub

    Private Sub RotationToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RotationToolStripMenuItem.Click
        Dim node As TreeNode = New TreeNode("Rotation")
        node.Tag = Nothing
        node.ContextMenuStrip = ControlEditContextMenuStrip
        uArmTreeView.SelectedNode.Nodes.Add(node)
    End Sub

    Private Sub StretchToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles StretchToolStripMenuItem.Click
        Dim node As TreeNode = New TreeNode("Stretch")
        node.Tag = Nothing
        node.ContextMenuStrip = ControlEditContextMenuStrip
        uArmTreeView.SelectedNode.Nodes.Add(node)
    End Sub

    Private Sub HeightToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles HeightToolStripMenuItem.Click
        Dim node As TreeNode = New TreeNode("Height")
        node.Tag = Nothing
        node.ContextMenuStrip = ControlEditContextMenuStrip
        uArmTreeView.SelectedNode.Nodes.Add(node)
    End Sub

    Private Sub WristToolStripMenuItem_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles WristToolStripMenuItem.Click
        Dim node As TreeNode = New TreeNode("Wrist")
        node.Tag = Nothing
        node.ContextMenuStrip = ControlEditContextMenuStrip
        uArmTreeView.SelectedNode.Nodes.Add(node)
    End Sub

    Private Sub EffectorToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles EffectorToolStripMenuItem.Click
        Dim node As TreeNode = New TreeNode("Effector")
        node.Tag = Nothing
        node.ContextMenuStrip = ControlEditContextMenuStrip
        uArmTreeView.SelectedNode.Nodes.Add(node)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
        uArmTreeView.SelectedNode.Remove()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim obj As JoystickObjects = uArmTreeView.SelectedNode.Parent.Tag
        Dim dlg As Form = Nothing
        Select Case obj.Type
            Case JoystickObjects.DirectInputObjectType.BUTTON
                dlg = New ButtonConfigDialog
            Case JoystickObjects.DirectInputObjectType.AXIS
                dlg = New AxisConfigDialog
            Case JoystickObjects.DirectInputObjectType.POV
                dlg = New POVConfigDialog
        End Select
        If dlg IsNot Nothing Then
            Dim result As System.Windows.Forms.DialogResult = DialogResult.Cancel
            dlg.Text = uArmTreeView.SelectedNode.Text
            dlg.Tag = obj
            result = dlg.ShowDialog()
            If result = System.Windows.Forms.DialogResult.OK Then
                uArmTreeView.SelectedNode.Parent.Tag = dlg.Tag
            End If
        End If
    End Sub

#End Region

End Class
