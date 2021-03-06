﻿'**********************************************************************************
'* Copyright (C) 2007,2014 Hitachi Solutions,Ltd.
'**********************************************************************************

#Region "Apache License"
'
' Licensed to the Apache Software Foundation (ASF) under one or more 
' contributor license agreements. See the NOTICE file distributed with
' this work for additional information regarding copyright ownership. 
' The ASF licenses this file to you under the Apache License, Version 2.0
' (the "License"); you may not use this file except in compliance with 
' the License. You may obtain a copy of the License at
'
' http://www.apache.org/licenses/LICENSE-2.0
'
' Unless required by applicable law or agreed to in writing, software
' distributed under the License is distributed on an "AS IS" BASIS,
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
' See the License for the specific language governing permissions and
' limitations under the License.
'
#End Region

'**********************************************************************************
'* クラス名        ：MyLiteral
'* クラス日本語名  ：Business層のリテラル クラス（必要なリテラルを追加）（テンプレート）
'*
'* 作成者          ：生技 西野
'* 更新履歴        ：
'*
'*  日時        更新者            内容
'*  ----------  ----------------  -------------------------------------------------
'*  20xx/xx/xx  ＸＸ ＸＸ         新規作成（テンプレート）
'*  2009/06/02  西野  大介        sln - IR版からの修正
'*                                ・#6 ： Fxプレフィックスの欠如
'*  2009/07/21  西野  大介        コントロール取得処理の仕様変更
'*  2010/10/21  西野  大介        幾つかのイベント処理の正式対応（ベースクラス２→１へ）
'*  2011/11/20  西野  大介        リッチクライアント用P層フレームワークを追加
'**********************************************************************************

' System
Imports System

Namespace Touryo.Infrastructure.Business.Util
    ''' <summary>Business層のリテラル クラス</summary>
    Public Class MyLiteral
#Region "app.configのキー（とデフォルト値）"

        ' 2009/07/21-start

#Region "コントロールのプレフィックス"

        ''' <summary>チェック ボックスのプレフィックスを設定するキー。</summary>
        ''' <remarks>ベースクラス２から利用するので、internal</remarks>
        Public Const PREFIX_OF_CHECK_BOX As String = "FxPrefixOfCheckBox"

#End Region

        ' 2009/07/21-end

#End Region

#Region "P層のリテラル"

        ' 2009/07/21-start ～ end

#Region "イベントハンドラのヘッダ・フッタ"

        '// <summary>UOCメソッドフッタ（CheckedChanged）</summary>
        'public const string UOC_METHOD_FOOTER_CHECKED_CHANGED = "CheckedChanged";

#End Region

#End Region
    End Class
End Namespace
