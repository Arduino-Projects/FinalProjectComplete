﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,")>  _
        Public Property Leaderboard() As String
            Get
                Return CType(Me("Leaderboard"),String)
            End Get
            Set
                Me("Leaderboard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,Anonymous 0,")>  _
        Public Property TopScores() As String
            Get
                Return CType(Me("TopScores"),String)
            End Get
            Set
                Me("TopScores") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Araad 17, Derek 14, Araad 13, Araad 12, Derek 5,")>  _
        Public Property TopScoresSrvl() As String
            Get
                Return CType(Me("TopScoresSrvl"),String)
            End Get
            Set
                Me("TopScoresSrvl") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Red")>  _
        Public Property Red() As Global.System.Drawing.Color
            Get
                Return CType(Me("Red"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Red") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DarkBlue")>  _
        Public Property Blue() As Global.System.Drawing.Color
            Get
                Return CType(Me("Blue"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Blue") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Green")>  _
        Public Property Green() As Global.System.Drawing.Color
            Get
                Return CType(Me("Green"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Green") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Gold")>  _
        Public Property Yellow() As Global.System.Drawing.Color
            Get
                Return CType(Me("Yellow"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Yellow") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SkyBlue")>  _
        Public Property LightBlue() As Global.System.Drawing.Color
            Get
                Return CType(Me("LightBlue"),Global.System.Drawing.Color)
            End Get
            Set
                Me("LightBlue") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Orange")>  _
        Public Property Orange() As Global.System.Drawing.Color
            Get
                Return CType(Me("Orange"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Orange") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Purple")>  _
        Public Property Purple() As Global.System.Drawing.Color
            Get
                Return CType(Me("Purple"),Global.System.Drawing.Color)
            End Get
            Set
                Me("Purple") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Fixed3D")>  _
        Public Property Border() As Global.System.Windows.Forms.BorderStyle
            Get
                Return CType(Me("Border"),Global.System.Windows.Forms.BorderStyle)
            End Get
            Set
                Me("Border") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TetrisFinalProject.My.MySettings
            Get
                Return Global.TetrisFinalProject.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace