using System;
using TechTalk.SpecFlow;

namespace ShalomTestFramework
{
    [Binding]
    public class PostingSteps
    {
        [Given(@"I am on the guestbook page")]
public void GivenIAmOnTheGuestbookPage()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I am on the posting page")]
public void GivenIAmOnThePostingPage()
{
    ScenarioContext.Current.Pending();
}

        [Given(@"I have filled out the form as follows")]
public void GivenIHaveFilledOutTheFormAsFollows(Table table)
{
    ScenarioContext.Current.Pending();
}

        [When(@"I click the button labelled ""(.*)""")]
public void WhenIClickTheButtonLabelled(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I should see a button labelled ""(.*)""")]
public void ThenIShouldSeeAButtonLabelled(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I am on the posting page")]
public void ThenIAmOnThePostingPage()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I should see a field labelled ""(.*)""")]
public void ThenIShouldSeeAFieldLabelled(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I should be on the guestbook page")]
public void ThenIShouldBeOnTheGuestbookPage()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I see the flash message ""(.*)""")]
public void ThenISeeTheFlashMessage(string p0)
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the guestbook entries includes the following")]
public void ThenTheGuestbookEntriesIncludesTheFollowing(Table table)
{
    ScenarioContext.Current.Pending();
}
    }
}
