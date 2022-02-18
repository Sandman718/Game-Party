import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutPlayerFormComponent } from './about-player-form.component';

describe('AboutPlayerFormComponent', () => {
  let component: AboutPlayerFormComponent;
  let fixture: ComponentFixture<AboutPlayerFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AboutPlayerFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutPlayerFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
