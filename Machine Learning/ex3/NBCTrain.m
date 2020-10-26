function [meanOfAttributes, stdOfAttributes, priorProb] = NBCTrain(AttributeSet, LabelSet)
format long
uniqueConditions = unique(LabelSet);
%uniqueAttributes = unique(AttributeSet);
noOfExamples = size(AttributeSet,1);
noOfConditions = size(uniqueConditions,1);
noOfAttributes = size(AttributeSet,2);
%noOfAttributeValues = size(uniqueAttributes,1);
noOfUniqueConditions = zeros(1,noOfConditions);
priorProb = zeros(1,noOfConditions);
%conditionTables = cell(1,noOfAttributes);

meanOfAttributes = zeros(noOfConditions,noOfAttributes);
stdOfAttributes = zeros(noOfConditions,noOfAttributes);
conditionCell = cell(noOfConditions,1);
conditionCount = zeros(1,noOfConditions);


%sets up the conditionCell
for i = 1:noOfConditions
    noOfUniqueConditions(1,i) = sum(LabelSet == uniqueConditions(i,1));
    priorProb(1,i) = noOfUniqueConditions(1,i)/noOfExamples;
    conditionCell{i,1} = zeros(noOfUniqueConditions(1,i),noOfAttributes);
end

for i = 1:noOfConditions
    for j = 1:noOfExamples
        if (LabelSet(j,1) == uniqueConditions(i,1))
            conditionCount(1,i) = conditionCount(1,i) + 1;
            conditionCell{i,1}(conditionCount(1,i),:) = AttributeSet(j,:);
        end
    end
end

for j = 1:noOfConditions
     for k = 1:noOfAttributes
            meanOfAttributes(j,k) = mean(conditionCell{j,1}(:,k));
     end
end             

                
for i = 1:noOfConditions
    for j = 1:noOfAttributes
        stdOfAttributes(i,j) = std(conditionCell{i,1}(:,j),0);
    end
end
           







