import { TestBed } from '@angular/core/testing';

import { WeekPlanService } from './week-plan.service';

describe('WeekPlanService', () => {
  let service: WeekPlanService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(WeekPlanService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
