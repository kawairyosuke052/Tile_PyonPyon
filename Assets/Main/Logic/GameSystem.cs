using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームシステムの中心となるクラス
///
/// このゲームの仕組み：
/// - マウスカーソルの位置がプレイヤーの位置として扱われます
/// - 地面タイルが定期的に生成・削除されます
/// - プレイヤー（マウス）が地面タイルの上にいる必要があります
/// - 地面がない場所にマウスを移動するとゲームオーバーです
///
/// タイルの色：
/// - 緑色：安全な地面（次の更新まで残る）
/// - 黄色：警告（もうすぐ消える）
/// </summary>
public class GameSystem
{
    
}