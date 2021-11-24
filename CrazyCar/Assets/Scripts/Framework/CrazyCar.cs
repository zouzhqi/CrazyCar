﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TFramework;

public class CrazyCar : Architecture<CrazyCar> {
    protected override void Init() {
        RegisterSystem<IResourceSystem>(new ResourceSystem());
        RegisterModel<IUserModel>(new UserModel());
        RegisterModel<IAvatarModel>(new AvatarModel());
        RegisterModel<ITimeTrialModel>(new TimeTrialModel());
        RegisterModel<IMatchModel>(new MatchModel());
        RegisterModel<IEquipModel>(new EquipModel());
        RegisterModel<ISettingsModel>(new SettingsModel());
        RegisterUtility<IPlayerPrefsStorage>(new PlayerPrefsStorage());
    }
}
