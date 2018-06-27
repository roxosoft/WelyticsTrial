import { RIMIKSTemplatePage } from './app.po';

describe('RIMIKS App', function() {
  let page: RIMIKSTemplatePage;

  beforeEach(() => {
    page = new RIMIKSTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
