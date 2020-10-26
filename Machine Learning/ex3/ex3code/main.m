function main(part)
section = part;
%close all;
%clear all;


if (section == 1)
    fname = input('Enter a filename to load data for training/testing: ','s');
    load(fname);
    % Put your NB training function below
    [conditionTables, priorProb] = NBTrain(AttributeSet, LabelSet); % NB training
    % Put your NB test function below
    [predictLabel, accuracy] = NBTest(conditionTables, priorProb, testAttributeSet, validLabel); % NB test

    ConfusionMatrix = confusionmat(validLabel,predictLabel)

    fprintf('********************************************** \n');
    fprintf('Overall Accuracy on Dataset %s: %f \n', fname, accuracy);
    fprintf('********************************************** \n');

end

if (section == 2)
    fname = input('Enter a filename to load data for training/testing of part 2: ','s');
    load(fname);

    [mean, std,prior] = NBCTrain(AttributeSet, LabelSet); % NB training
    % Put your NB test function below
    [predictLabel, accuracy] = NBCTest(mean,std, prior, testAttributeSet, validLabel); % NB test

    ConfusionMatrix2 = confusionmat(validLabel,predictLabel)

    fprintf('********************************************** \n');
    fprintf('Overall Accuracy on Dataset %s: %f \n', fname, accuracy);
    fprintf('********************************************** \n');

end
