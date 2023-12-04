﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBreakfvst.Contracts.Breakfvst;

public record BreakfastResponse(
  Guid Id,
  string Name,
  string Description,
  DateTime StartDateTime,
  DateTime EndDateTime,
  DateTime LastModifiedDateTime,
  List<string> Savory,
  List<string> Sweet);
