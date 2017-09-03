﻿using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Merlin.API.Direct
{
    public partial class LandscapeManager
    {
        public List<aea> GetUnrestrictedPvpZones => _internal.f().e;

        public bool IsInAnyUnrestrictedPvpZone(Vector3 location) => IsInAnyUnrestrictedPvpZone(GetUnrestrictedPvpZones, location);

        public bool IsInAnyUnrestrictedPvpZone(IEnumerable<aea> pvpZones, Vector3 location) => pvpZones.Any(pvpZone => Point2.Distance(pvpZone, location.d()) < pvpZone.m());

        public bool IsInAnyUnrestrictedPvpZone(Func<aea, bool> selector, Vector3 location) => IsInAnyUnrestrictedPvpZone(GetUnrestrictedPvpZones.Where(selector), location);
    }
}