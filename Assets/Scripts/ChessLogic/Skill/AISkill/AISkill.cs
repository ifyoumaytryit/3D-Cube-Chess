﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 这是所有AI技能的基类
/// 所有的AI技能都应当是非指向性技能
/// CAIComponent会在AIPreTurn调用Decide，然后在AIPostTurn调用Perform
/// </summary>
public abstract class AISkill : Skill
{
    /// <summary>
    /// 这是获取技能影响范围的函数
    /// 用以UI显示，提示怪物的技能影响范围
    /// </summary>
    /// <returns></returns>
    public abstract Vector2Int[] GetAffectRange();
    /// <summary>
    /// 根据选中的目标作出相应的决定，并存储决定
    /// </summary>
    /// <param name="target">CAIComponent选中的目标</param>
    public abstract void Decide(GChess target);
    /// <summary>
    /// 根据Decide函数设定的值进行行动
    /// </summary>
    public abstract void Perform();
}
