import { pocTemplatePage } from './app.po';

describe('poc App', function() {
  let page: pocTemplatePage;

  beforeEach(() => {
    page = new pocTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
