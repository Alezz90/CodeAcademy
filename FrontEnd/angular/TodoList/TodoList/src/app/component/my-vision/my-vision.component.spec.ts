import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyVisionComponent } from './my-vision.component';

describe('MyVisionComponent', () => {
  let component: MyVisionComponent;
  let fixture: ComponentFixture<MyVisionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MyVisionComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(MyVisionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
